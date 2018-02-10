#!/usr/bin/env python
# -*- coding: utf-8 -*-

import numpy as np
from timeit import default_timer as timer

def VectorAdd(a,b,c):
    for i in xrange(a.size):
        c[i] = a[i] + b[i]

def main():

    start = timer()

    for x in range(1):
        N=32000000
        A=np.ones(N,dtype=np.float32)
        B=np.ones(N,dtype=np.float32)
        C=np.zeros(N,dtype=np.float32)
        VectorAdd(A, B, C)

    vectoradd_time = timer() - start
    print("VectorAdd tppl %f seconds" % vectoradd_time)

if __name__ == '__main__':
    main()
