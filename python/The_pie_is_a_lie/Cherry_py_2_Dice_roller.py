from random import randint as dice
import roll_round, time

player_1 = input('Player One, introduce yourself: ')
player_2 = input('Player Two, introduce yourself: ')

print('GREATER DICE will choose how many times you are to roll\n')
time.sleep(5)

this_many = dice(1,10)
if this_many == 1:
    print('You will roll only once\n'
        +'The winner is the one who gets more points\n'
        +'START!\n'
        +'Roll the dice, '+player_1)
else:
    print('You will roll '+str(this_many)+' times\n'
        +'The winner is the one who gets more points after '+str(this_many)+' rolls\n'
        +'START!\n'
        +'Roll the dice, '+player_1)
time.sleep(5)

total_for_player_1 = roll_round.roll_round(dice, this_many)
print(player_1+', you get '+str(total_for_player_1))
time.sleep(3)

print('Now it is '+player_2+'\'s turn to roll!\n START!')
total_for_player_2 = roll_round.roll_round(dice, this_many)
print(player_2+', you get '+str(total_for_player_2))

time.sleep(2)
print('We are done. Now let\'s see who won')
time.sleep(2)

if total_for_player_1 > total_for_player_2:
    print(player_1+' is the winner!')
elif total_for_player_1 < total_for_player_2:
    print(player_2+' is the winner!')
else:
    print('Draw, no winner')