import playsound
from time import sleep 

n = 0
s = 0
i = 1

welcome = 'Cherry_pie_3\Assets\Messages\Welcome.mp3'
buzzer = 'Cherry_pie_3\Assets\Messages\Buzzer.mp3'
playsound(welcome)

while n <= 0:
    playsound.playsound(buzzer)
    n = int(input())

for i in range(1,n):
    playsound(buzzer)
    d = int(input())
    s += d
    i = i + 1 

if n == 1:
    mid = s/i
else:    
    mid = s/(i-1)
print(mid)