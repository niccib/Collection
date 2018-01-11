def get_initials(fullname):
    """ Given a person's name, returns the person's initials (uppercase) """
    name_list = fullname.split()
    init = ""
    for name in name_list:
        init = init + name [0]
    return init.upper()

def main():
    full_name = input("What is your name?")
    get_initials(full_name)

if __name__ == "__main__":
    main()

