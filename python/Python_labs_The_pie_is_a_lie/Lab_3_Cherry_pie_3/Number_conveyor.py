from random import randint as dice, sample
from math import floor

sample_num = dice(1,999)
num_of_hundreds = floor(sample_num / 100)
num_of_tens = floor( (sample_num - (num_of_hundreds*100)) / 10) 
num_of_singles = sample_num - (num_of_hundreds*100) - (num_of_tens*10)