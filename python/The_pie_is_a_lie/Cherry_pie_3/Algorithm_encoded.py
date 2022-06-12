import playsound

n = 0
s = 0
i = 1

welcome = 'Cherry_pie_3\Assets\Messages\Welcome.mp3'
buzzer = 'Cherry_pie_3\Assets\Messages\Buzzer.mp3'
playsound.playsound(welcome)

while n <= 0:
    playsound.playsound(buzzer)
    n = int(input())

for i in range(1,n+1):
    playsound.playsound(buzzer)
    d = int(input())
    s += d
    i = i + 1 

mid = s/(i-1)
print(mid)