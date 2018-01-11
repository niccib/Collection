def alphabet_position(letter):
    alpha = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N',
             'O','P','Q','R','S','T','U','V','W','X','Y','Z']
    alpha2 = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n',
              'o','p','q','r','s','t','u','v','w','x','y','z']
    if letter in alpha:
        finder = alpha.index(letter)
        return finder
    else:
        getit = alpha2.index(letter)
        return  getit

def rotate_character(char,rot):
    alpha = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N',
             'O','P','Q','R','S','T','U','V','W','X','Y','Z']
    alpha2 = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n',
              'o','p','q','r','s','t','u','v','w','x','y','z']  
    if char in alpha:
        old_pos = alphabet_position(char)
        new_pos = (old_pos + rot)%26
        return alpha[new_pos]
    elif char in alpha2:
        old_pos = alphabet_position(char)
        new_pos = (old_pos + rot)%26
        return alpha2[new_pos]
    
    else:
        return char