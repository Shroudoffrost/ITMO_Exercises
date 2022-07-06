from Exception_pack import wrong_ingredient
import time

pie = ['dough', 'chocolate']

print(pie)
try:
    new_ingredient = input('add something: ')
    if new_ingredient != 'cherry':
        raise wrong_ingredient
except wrong_ingredient:
    print('Only cherry can be at the top')
    time.sleep(2)
    print('fine. I\'ll eat it anyways')
else:        
    pie.append(new_ingredient)
    print(pie)



# new_ingredient = input('add something: ')
# if new_ingredient != 'cherry':
#     print('Only cherry can be at the top')
# else:
#     print('fine. I\'ll eat it anyways')