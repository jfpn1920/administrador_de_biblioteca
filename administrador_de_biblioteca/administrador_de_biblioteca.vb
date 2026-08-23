Imports System
Module administrador_de_biblioteca
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim titulos(9) As String
        Dim autores(9) As String
        Dim categorias(9) As String
        Dim anios(9) As Integer
        Dim usuarios(9) As String
        Dim fechasPrestamo(9) As String
        Dim fechasDevolucion(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------------//
        '--|menu_principal_administrador_de_biblioteca|--//
        '------------------------------------------------//
        Do
            Console.WriteLine("menu principal administrador de biblioteca")
            Console.WriteLine("1) Registrar libro")
            Console.WriteLine("2) Editar libro")
            Console.WriteLine("3) Listar libros")
            Console.WriteLine("4) Buscar libro")
            Console.WriteLine("5) Eliminar libro")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '---------------------//
                '--|registrar_libro|--//
                '---------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas libros.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de libro")
                        Console.Write("Titulo: ")
                        titulos(cantidad) = Console.ReadLine()
                        Console.Write("Autor: ")
                        autores(cantidad) = Console.ReadLine()
                        Console.Write("Categoria: ")
                        categorias(cantidad) = Console.ReadLine()
                        Console.Write("Año: ")
                        anios(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Usuario: ")
                        usuarios(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de prestamo: ")
                        fechasPrestamo(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de devolucion: ")
                        fechasDevolucion(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observaciones: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Libro registrado correctamente.")
                    End If
                '------------------//
                '--|editar_libro|--//
                '------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen libros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Titulo: " & titulos(i) & " | Autor: " & autores(i) & " | Categoria: " & categorias(i) & " | Año: " & anios(i) & " | Usuario: " & usuarios(i) & " | Fecha prestamo: " & fechasPrestamo(i) & " | Fecha devolucion: " & fechasDevolucion(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del libro a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo titulo: ")
                            titulos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo autor: ")
                            autores(posicion) = Console.ReadLine()
                            Console.Write("Nueva categoria: ")
                            categorias(posicion) = Console.ReadLine()
                            Console.Write("Nuevo año: ")
                            anios(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nuevo usuario: ")
                            usuarios(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de prestamo: ")
                            fechasPrestamo(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de devolucion: ")
                            fechasDevolucion(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nuevas observaciones: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Libro actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------//
                '--|listar_libros|--//
                '-------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen libros registrados.")
                    Else
                        Console.WriteLine("lista de libros")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Titulo: " & titulos(i) & " | Autor: " & autores(i) & " | Categoria: " & categorias(i) & " | Año: " & anios(i) & " | Usuario: " & usuarios(i) & " | Fecha prestamo: " & fechasPrestamo(i) & " | Fecha devolucion: " & fechasDevolucion(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                    End If
                '------------------//
                '--|buscar_libro|--//
                '------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen libros registrados.")
                    Else
                        Console.Write("Ingrese el ID del libro a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("libro encontrado")
                            Console.WriteLine("ID: " & ids(posicion) & " | Titulo: " & titulos(posicion) & " | Autor: " & autores(posicion) & " | Categoria: " & categorias(posicion) & " | Año: " & anios(posicion) & " | Usuario: " & usuarios(posicion) & " | Fecha prestamo: " & fechasPrestamo(posicion) & " | Fecha devolucion: " & fechasDevolucion(posicion) & " | Estado: " & estados(posicion) & " | Observaciones: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------//
                '--|eliminar_libro|--//
                '--------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen libros registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Titulo: " & titulos(i) & " | Autor: " & autores(i) & " | Categoria: " & categorias(i) & " | Año: " & anios(i) & " | Usuario: " & usuarios(i) & " | Fecha prestamo: " & fechasPrestamo(i) & " | Fecha devolucion: " & fechasDevolucion(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del libro a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                titulos(i) = titulos(i + 1)
                                autores(i) = autores(i + 1)
                                categorias(i) = categorias(i + 1)
                                anios(i) = anios(i + 1)
                                usuarios(i) = usuarios(i + 1)
                                fechasPrestamo(i) = fechasPrestamo(i + 1)
                                fechasDevolucion(i) = fechasDevolucion(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Libro eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen libros registrados.")
                    Else
                        Dim disponibles As Integer = 0
                        Dim prestados As Integer = 0
                        Dim reservados As Integer = 0
                        Dim devueltos As Integer = 0
                        Dim perdidos As Integer = 0
                        Dim novelas As Integer = 0
                        Dim ciencias As Integer = 0
                        Dim historias As Integer = 0
                        Dim tecnologias As Integer = 0
                        Dim educacion As Integer = 0
                        Dim fantasias As Integer = 0
                        Dim otros As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i).ToLower() = "disponible" Then
                                disponibles += 1
                            ElseIf estados(i).ToLower() = "prestado" Then
                                prestados += 1
                            ElseIf estados(i).ToLower() = "reservado" Then
                                reservados += 1
                            ElseIf estados(i).ToLower() = "devuelto" Then
                                devueltos += 1
                            ElseIf estados(i).ToLower() = "perdido" Then
                                perdidos += 1
                            End If
                            If categorias(i).ToLower() = "novela" Then
                                novelas += 1
                            ElseIf categorias(i).ToLower() = "ciencia" Then
                                ciencias += 1
                            ElseIf categorias(i).ToLower() = "historia" Then
                                historias += 1
                            ElseIf categorias(i).ToLower() = "tecnologia" Then
                                tecnologias += 1
                            ElseIf categorias(i).ToLower() = "educacion" Then
                                educacion += 1
                            ElseIf categorias(i).ToLower() = "fantasia" Then
                                fantasias += 1
                            Else
                                otros += 1
                            End If
                        Next
                        Dim porcentajeDisponibles As Double = (disponibles * 100) / cantidad
                        Console.WriteLine("resumen de administrador de biblioteca")
                        Console.WriteLine("Libros registrados: " & cantidad & " | Disponibles: " & disponibles & " | Prestados: " & prestados & " | Reservados: " & reservados & " | Devueltos: " & devueltos & " | Perdidos: " & perdidos & " | Novelas: " & novelas & " | Ciencias: " & ciencias & " | Historia: " & historias & " | Tecnologia: " & tecnologias & " | Educacion: " & educacion & " | Fantasia: " & fantasias & " | Otros: " & otros & " | Disponibilidad: " & Math.Round(porcentajeDisponibles, 2) & "%")
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Administrador de Biblioteca.")

                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module