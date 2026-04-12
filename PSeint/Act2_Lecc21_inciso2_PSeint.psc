Algoritmo Act2_Lecc21_inciso2_PSeint
	Definir num Como Entero
	Escribir "===Buzon de vos de: Contru Herrera==="
	Escribir "Ingrese uno los siguientes"
	Escribir "numeros si quiere comunicarse con:"
	Escribir "1: Ventas"
	Escribir "2: Recepcion"
	Escribir "3: Direccion"
	Escribir "4: Compras"
	Leer num
	
	Segun num Hacer
		1:
			Escribir "Bienvenido al departamento de: VENTAS"
			Escribir "Correo del responsable: cherrera@gmail.com"
		2:
			Escribir "Bienvenido al departamento de: RECEPCION"
			Escribir "Correo del responsable: angeliagarcia@gmail.com"
		3:
			Escribir "Bienvenido al departamento de: DIRECCION"
			Escribir "Correo del responsable: jjose1976@gmail.com"
		4:
			Escribir "Bienvenido al departamento de: COMPRAS"
			Escribir "Correo del responsable: rramirez08@gmail.com"
		De Otro Modo:
			Escribir "Ingrese un numero valido"
	Fin Segun
FinAlgoritmo