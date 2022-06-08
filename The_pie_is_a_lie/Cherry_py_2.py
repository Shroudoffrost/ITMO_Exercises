# this = "Where is the money, Lebowski?"
# that = "We want that money, Lebowski!"
# print('length of this is '+str(len(this)))
# print(this+'\n'+that.upper())
# loaf = "Bread"
# toast = loaf[3:5]
# butter = " peanut"
# print(toast+butter)

# cash = 322
# crypto = 42
# money = "{:.2f}".format(cash+crypto)
# print(money)

# word_1 = input("you are on camera, say something: ");
# word_2 = input("keep talkin': ");
# #print("I repeat: "+result)
# #print("Press any key to continue . . .");
# #print(this)

# a = 1/3
# print("{:7.3f}".format(a))

# a = 2/3
# b = 2/9
# print("{:7.3f} {:7.3f}".format(a, b))
# print("{:10.3e} {:10.3e}".format(a, b))

# chaos = [2,1,4,5,6,3,7]
# order = sorted(chaos)
# print(order)

negative_answer = 'are not on the list.\n  Goodbye and never come back.'
positive_answer = 'oh, hi'
guests = ['I','you','we','he','she','they']
who = 'you '
guests.remove('you')

def try_to_enter():
    if guests.__contains__(who):
        print(' — '+positive_answer)
    else:
        print(' — '+who+negative_answer)

try_to_enter()

print(' — but wait!')
response = input('\n    *make a phonecall? [y/n]* : ')
if response == 'y':
    guests.append('you ')
    try_to_enter()
else:
    print((who+negative_answer).upper())
