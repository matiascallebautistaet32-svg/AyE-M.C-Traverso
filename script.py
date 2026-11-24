import random

#Ejercicio_1
numsecret = random.randint(1, 10)
intentos = 0

print("Adivina un numero del 1 al 10")

while True:

        adivinanza = int(input("Adivinalo: "))
        intentos += 1

        if adivinanza < numsecret:
            print("Mas alto")
        elif adivinanza > numsecret:
            print("Mas bajo")
        else:
            print(f"¡Adivinaste el número {numsecret} en {intentos} intento(s).")
            break

#Ejercicio_2

num = int(input("Ingrese un numero: "))

for i in range(1, num+1):
    if num % i == 0:
        print(f"{i} es divisor")

#Ejercicio_3
a, b = 0, 1
serie = []

for _ in range(20):
    a, b = b, a + b
    print(a)

print(serie)

#Ejercicio_4

print("=== CALCULADORA ===")
print("1. Suma")
print("2. Resta")
print("3. Multiplicación")
print("4. División")

opcion = input("Elegí una operación (1-2-3-4): ")

num1 = int(input("Ingrese el primer numero: "))
num2 = int(input("Ingrese el segundo numero: "))

if opcion == "1":
    print(f"Resultado: {num1 + num2}")
elif opcion == "2":
    print(f"Resultado: {num1 - num2}")
elif opcion == "3":
    print(f"Resultado: {num1 * num2}")
elif opcion == "4":
    if num2 != 0:
        print(f"Resultado: {num1 / num2}")
    else:
        print("No se puede dividir por cero.")
else:
    print("Opcion no valida.")

#Ejercicio_5

num = int(input("Ingrese un numero: "))
acum= 1

for i in range(1, num+1):
    acum *= i

print(acum)


#Ejercicio_6

turnos = []

while True:
    nombre = input("Nombre o fin para salir): ")
    if nombre == "fin":
        break
    turnos.append(nombre)

numero = 1
for persona in turnos:
    print("Turno", numero, ":", persona)
    numero = numero + 1

#Ejercicio_7

cont = 0
for i in range(1, 101):
    if i % 2 == 0:
        cont += 1
print(cont)

#Ejercicio_8

    seguir = "si"

    while seguir == "si":
        c = float(input("Grados Celsius: "))
        f = (c * 9 / 5) + 32
        print("Fahrenheit:", f)
        seguir = input("Convertir otro? si o no: ")


#Ejercicio_9

    num = int(input("Ingrese un número: "))
    divisores = 0
    for i in range(1, num + 1):
        if num % i == 0:
            divisores = divisores + 1
    if divisores == 2:
        print("Es primo")
    else:
        print("No es primo")

#Ejercicio_10

    nombres = []
    nombre = input("Ingrese un nombre o fin: ")
    while nombre != "fin":
        nombres.append(nombre)
        nombre = input("Ingrese un nombre o fin: ")

    for n in nombres:
        print("Hola", n)

#Ejercicio_11

    nombres = []
    repetido = False
    while repetido == False:
        nombre = input("Ingresá un nombre: ")
        if nombre in nombres:
            repetido = True
        else:
            nombres.append(nombre)
    print("Ingresaste", len(nombres), "nombres antes del repetido")

#Ejercicio_12

    for i in range(100, 201):
        if i % 7 == 0 and i % 10 == 3:
            print(i)

#Ejercicio_13

    tot = 0
    cant = 0
    while tot <= 1000:
        precio = float(input("Precio del producto: "))
        total = tot + precio
        cant = cant + 1
    print("Productos cargados:", cant)

#Ejercicio_14

    nombre = input("Nombre: ")
    edad = input("Edad: ")
    while edad.isdigit() == False:
        edad = input("Edad invalida. Ingrese un número: ")

    mail = input("Mail: ")
    while "@" not in mail:
        mail = input("Debe tener @: ")

    print("Datos:", nombre, edad, mail)

#Ejercicio_15

    numero = input("Ingrese un numero: ")
    for digito in numero:
        print(digito)

#Ejercicio_16

    opc = ["piedra", "papel", "tijera"]
    usuariopt = 0
    pcpt = 0
    for i in range(3):
        usuario = input("Elegi piedra, papel o tijera: ")
        pc = random.choice(opc)
        print("PC eligio:", pc)
        if usuario == pc:
            print("Empate")
        elif (usuario == "piedra" and pc == "tijera") or (usuario == "papel" and pc == "piedra") or (
                usuario == "tijera" and pc == "papel"):
            print("Ganaste ronda")
            usuariopt = usuariopt + 1
        else:
            print("Gano PC")
            pcpt = pcpt + 1

    if usuariopt > pcpt:
        print("Ganaste el juego")
    elif pcpt > usuariopt:
        print("Gano la compu")
    else:
        print("Empate")

#Ejercicio_17

    mayor = 0
    for i in range(10):
        num = random.randint(1, 100)
        print(num)
        if num > 50:
            mayor = mayor + 1
    print("Mayores a 50:", mayor)

#Ejercicio_18

    suma = 0
    mejornota = -1
    mejornombre = ""
    for i in range(5):
        nombre = input("Nombre: ")
        nota = float(input("Nota: "))
        suma = suma + nota
        if nota > mejornota:
            mejornota = nota
            mejornombre = nombre
    print("Promedio:", suma / 5)
    print("Mejor nota:", mejornombre, "con", mejornota)

#Ejercicio_19

    letras = "abcdefghijklmnñopqrstuvwxyz"
    for letra in letras:
      print(letra)
