from helpers import alphabet_position, rotate_character

def encrypt(text,rot):
    encrypted = ''
    for char in text:
        word = rotate_character(char,rot)
        encrypted += word
    return encrypted

def main():
    message = input("Please enter a message to encrypt: ")
    rot_num = int(input("What number of rotations?"))
    print(encrypt(message,rot_num))
    
if __name__ == "__main__":
    main()