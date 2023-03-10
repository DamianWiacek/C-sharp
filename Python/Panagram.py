import string

def is_pangram(s):
    wyn =[]
    for x in s.lower():
        if x not in wyn and x in string.ascii_letters:
            wyn.append(x)
    return True if len(wyn) >= len(string.ascii_lowercase) else False