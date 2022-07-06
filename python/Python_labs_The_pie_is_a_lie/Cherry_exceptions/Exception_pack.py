class wrong_ingredient(Exception):
    def __str__(self):
        return 'Only cherry can be at the top'