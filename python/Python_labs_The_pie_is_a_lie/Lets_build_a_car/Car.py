from string import whitespace


class Car:
    color = 'white'
    def __init__(self, color, wheels, plate):
        self.color = color
        self.wheels = wheels
        self.plate = plate

    def honk():
        print('honk-honk')

    def Start():
        print('no engine')