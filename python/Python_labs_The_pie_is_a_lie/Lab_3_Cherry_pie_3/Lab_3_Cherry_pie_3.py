# import math, statistics
from random import randint as dice
from statistics import mean, median, stdev
from math import fsum

sample_numbers = []

for i in range(10):
    sample_numbers.append(dice(1,100))

sample_numbers.sort()

print('\nsum: '+str(fsum(sample_numbers)),
      '\nmean: '+str(mean(sample_numbers)),
      '\nmedian: '+str(median(sample_numbers)),
      '\ndevitation: '+'{:.1f}'.format(stdev(sample_numbers)),'\n')