Algoritmo Act1_Lecc7_inciso1_PSeint
	Definir n1, n2, n3, n4, n5, p Como Real
	Escribir "Escriba sus 5 notas de la clase:"
	Leer n1
	Leer n2
	Leer n3
	Leer n4
	Leer n5
	p = (n1+n2+n3+n4+n5)/5
	
	Si p >= 70 Entonces
		Escribir "Ha aprobado la clase"
		Escribir "Promedio: ",p
	SiNo
		Escribir "Ha reprobado la clase"
		Escribir "Promedio: ",p
	Fin Si
	
FinAlgoritmo
