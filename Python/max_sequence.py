# The maximum sum subarray problem consists in finding the maximum sum of a contiguous
# subsequence in an array or list of integers:
# maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
# -- should be 6: [4, -1, 2, 1]

def max_sequence(arr):
    wynik = 0
    suma = 0
    for i in arr:
        suma += i
        if suma<0:
            suma =0
        if suma > wynik:
            wynik = suma
    return wynik       