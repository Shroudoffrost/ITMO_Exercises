def roll(dice, this_many):
    total_points = 0
    roll_num = 0
    while roll_num < this_many:
        total_points = total_points + dice(1,6)
        roll_num += 1
    return total_points