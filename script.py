#Ejercicio1
for i in range (1,100):
  if i % 3 == 0:
    print(i)

#Ejercicio2
edad = int(input("Ingresa tu edad: "))
if edad > 18:
    print("Eres mayor de edad")
elif edad < 18:
    print("Eres menor de edad")
else:
    print("tienes 18")

#Ejercicio3
palabra = input("Ingresa una palabra: ")
print("La palabra tiene:",len(palabra), "letras")


#Ejercicio4
contrasecreta = "opalonio333"
for i in range(5):
    contra = input("Ingrese la contraseña(solo tiene 5 intentos): ")
    if contra == contrasecreta:
        print("Acceso Concedido")
        break
    else:
        print("No sabes la contra ")


#Ejercicio5
numalto = 1
for i in range(10):
    numingresado = int(input("Ingrese un numero: "))
    if numingresado > numalto:
        numalto =+ numingresado
print("El numero mas alto es:",numalto)


#Ejercicio6
nombre = input("Ingrese su nombre: ")
print("Hola {nombre.title()}")


#Ejercicio7
for i  in range(1,71):
    if i % 7 == 0:
        print(i)


#Ejercicio8
for i in range(10,0 ,-1):
    print(i)
    if i == 1:
        print("oa")


#Ejercicio9
numingresado = int(input("Ingrese un numero: "))

if numingresado % 2 == 0:
    print("Par")
else:
    print("impar")


#Ejercicio10
vocales = ["a","e","i","o","u"]
cont = 0
frase = input("Ingrese una frase: ")
for letra in frase:
 if letra in vocales:
     cont = cont+1
print("cantidad de vocales", cont)


#Ejercicio11
numingresado = int(input("Ingrese un numero: "))
for i in range(1, 13):
    print(numingresado * i)


#Ejercicio12
nummax= 100
cont = 0
while cont < nummax:
    numingresado = int(input("Ingrese un numero: "))
    cont = cont + numingresado
    if cont > nummax:
        break

#Ejercicio13
    palabra = input("Ingresa una palabra: ")
    for letra in palabra:
        print(letra)
#Ejercicio14
    edad = int(input("Ingresa tu edad: "))
    if edad >= 16 and edad >= 17:
        print("Puede votar y manejar.")
    elif edad >= 16:
        print("Solo puede votar.")
    elif edad >= 17:
        print("Solo puede manejar.")
    else:
        print("No puede hacer ninguna de las dos cosas.")
#Ejercicio15
    for x in range(50,0,-5):
        print(x)
#Ejercicio16
    ContraseñaSecreta = "ABCde5"
    for x in range(2):
        Adivinar = input("Ingrese la contraseña: ")
        if Adivinar == ContraseñaSecreta:
            print("Acceso permitido")
            break;
        else:
            print("Acceso denegado")
#Ejercicio17
    LargoDelNombre = 0
    while LargoDelNombre < 10:
        LargoDelNombre = 0
        Nombre = input("Ingrese una nombre: ")
        for x in Nombre:
            LargoDelNombre += 1
#Ejercicio18
    Frase = input("Ingrese una frase: ")
    Frase = Frase.lower()
    CantidadDeA = 0
    for x in Frase:
        if (x == "a"):
            CantidadDeA += 1
    print("La cantidad de A es: ", CantidadDeA)


