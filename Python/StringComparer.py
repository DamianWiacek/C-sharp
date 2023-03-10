# Given two arrays a and b write a function comp(a, b) (orcompSame(a, b)) that checks whether the two arrays have
# the "same" elements, with the same multiplicities (the multiplicity of a member is the number of times it appears).
# "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
#

def comp(array1,array2):
    print(array1)
    print(array2)
    if array1 == None or array2 == None:
        return False
    elif len(array1)!=len(array2):
        return False
    counter = 0
    for x in array1:
        if (array2.count(x**2)) ==array1.count(x):
            counter +=1
    return True if counter == len(array1) else False