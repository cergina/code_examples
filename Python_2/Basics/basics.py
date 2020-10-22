#!/usr/bin/python2.7
# ^^ toto hore povie programu, aby vykonal subor ako python
# potom cez file nazovskriptu.py uvidime, ze sa jedna o python script

# vypis vsetkych argumentov progrmau
print(sys.argv)

# pocet vsetkych argumentov
len(sys.argv)

# vypis argumentu 1
print("Here is the argument 1, {0}".format(sys.argv[1]))

# ukazka vystupu do error file outputu na linuxe
sys.stderr.write("Name of a the script {0}\n".format(sys.argv[0]))
