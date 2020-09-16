import random as rand
import tkinter as tk
from tkinter import ttk
from functools import partial

root = tk.Tk()
root.title("Number guessing game")
root.minsize(640, 480)
root.maxsize(1920, 1080)

def init():
    global toBeGuessed
    toBeGuessed = -1

toBeGuessed = -1

def generateRandom():
    global toBeGuessed
    toBeGuessed = rand.randint(1, 20)
    print(toBeGuessed)

def WasItRight(guessed):
    #print("You sent: " + str(guessed.get()))
    if (guessed.get() == toBeGuessed):
        print("Correct")
        textToUpdate.set("Correct")
    else:
        print("Incorrect, correct was " + str(toBeGuessed))
        textToUpdate.set("Incorrect, correct was " + str(toBeGuessed))

#### premenne ######
textToUpdate = tk.StringVar()
number = tk.IntVar()

#### veci v GUI ######
# informacia o vysledku
infoLabel = tk.Label(root, textvariable = textToUpdate)
infoLabel.pack()

# vkladanie cisla ktore si user mysli ze bolo vygenerovane
numberBox = ttk.Entry(root, width = 15, textvariable = number)
numberBox.pack()

# generacia noveho cisla
genButt = ttk.Button(root, text = "Generate random number", command = generateRandom)
genButt.pack()

# poziadavka na porovnanie
completeButt = ttk.Button(root, text = "Compare", command = partial(WasItRight, number))
completeButt.pack()

root.mainloop()
