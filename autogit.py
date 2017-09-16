import os


os.system("git add .")
data=str(input("INSERT COMMIT"))
os.system("git commit -m " + data)
os.system("git push origin master") 