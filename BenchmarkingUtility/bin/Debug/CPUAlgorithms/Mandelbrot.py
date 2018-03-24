import numpy as numpy
from numba import njit

@njit
def mandel(x, y, iterations):
    cmplx = complex(x, y)
    z = 0
    for i in range(iterations):
        z = (z**2) + cmplx
        if (z.real * z.real + z.imag * z.imag) >= 4:
            return i
    return iterations

@njit
def fractal(min_x, max_x, min_y, max_y, image, width, height, iterations):

    size_x = (max_x - min_x) / width
    size_y = (max_y - min_y) / height

    for i in range(width):
        real_x = min_x + i * size_x
        for j in range(height):
            real_y = min_y + j * size_y
            color = mandel(real_x, real_y, iterations)
            image[j, i] = color

zeros = (1024, 1536)
image = numpy.zeros(zeros, dtype=numpy.uint8)
width = image.shape[1]
height = image.shape[0]

for x in range(250):
    fractal(-2.0, 1.0, -1.0, 1.0, image, width, height, 50)