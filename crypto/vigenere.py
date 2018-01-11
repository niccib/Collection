from helpers import alphabet_position, rotate_character

def encrypt(message,key_word):
    
    char_list = ''
    key_len = len(key_word)
    counter = 0
    for char in message:
        if char.isalpha():
            for ke in key_word[counter%key_len]:
                key_letters = alphabet_position(ke)
                newest = rotate_character(char,key_letters)
                char_list += newest
                counter += 1
        else:
            char_list += char
        
    return char_list
                   
def main():
    message = input("Please enter a message to encrypt: ")
    keyword = input("Please enter a keyword: ")
    print(encrypt(message,keyword))

if __name__ == "__main__":
    main()

