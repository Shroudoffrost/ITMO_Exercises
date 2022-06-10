from Cherry_py import cherry as the_top

x = int(input('what is X: '))
y = int(input('what is Y: '))

if (x == 0 or y == 0):
    print(the_top)
else:
    if y > 0:
        if x > 0:
            print('quater 1')
        else:
            print('quater 2')

    else:
        if x < 0:
            print('quater 3')
        else:
            print('quater 4')