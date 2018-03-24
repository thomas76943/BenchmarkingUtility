import numpy as numpy
from numba import njit
from numba import cuda

def mandel(x, y, iterations):
    cmplx = complex(x, y)
    z = 0
    for i in range(iterations):
        z = (z**2) + cmplx
        if (z.real * z.real + z.imag * z.imag) >= 4:
            return i
    return iterations

mandel = cuda.jit(device=True)(mandel)

@cuda.jit
def fractal(min_x, max_x, min_y, max_y, image, width, height, iterations):

    size_x = (max_x - min_x) / width
    size_y = (max_y - min_y) / height
    (start_x, start_y) = cuda.grid(2)
    grid_x = cuda.blockDim.x * cuda.gridDim.x
    grid_y = cuda.blockDim.y * cuda.gridDim.y

    for i in range(start_x, width, grid_x):
        real = min_x + i * size_x
        for j in range(start_y, height, grid_y):
            real2 = min_y + j * size_y
            image[j, i] = mandel(real, real2, iterations)

zeros = (1024, 1536)
blockdimensions = (32, 8)
griddimensions = (32, 16)
image = cuda.to_device(numpy.zeros(zeros, dtype=numpy.uint8))
width = image.shape[1]
height = image.shape[0]

for x in range(250):
    fractal[griddimensions, blockdimensions](-2.0, 1.0, -1.0, 1.0, image, width, height, 50)