def intCheck():
	while True:
		try:
			number = int(input("Enter a number: "))
			break
		except:
			print("That's not a valid option!")
	if (number % 2) == 0:
		print("The number is even")
	else:
		print("The number is odd")


def main():
	intCheck()

main()
