using System;

namespace Calculador_Examenes3{

    class Program{

        static void Main (string[] args){
            Apariencia();
            while (2 > 1){
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.Write("Materia: ");
                Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                string materia = Console.ReadLine();
                Console.ForegroundColor = System.ConsoleColor.Green;
                if (materia == "Inglés" || materia == "inglés" || materia == "Ingles" || materia == "ingles"){
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Readers-");
                    double notaReader = PedirNotas(false);
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Listenings-");
                    double notaListening = PedirNotas(false);
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Speakings-");
                    double notaSpeaking = PedirNotas(false);
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Readings-");
                    double notaReading = PedirNotas(false);
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Writings-");
                    double notaWriting = PedirNotas(false);
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Grammar-");
                    double notaGrammar = PedirNotas(false);
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    Console.WriteLine("-Vocabulary-");
                    double notaVocabulary = PedirNotas(false);

                    double notaFinalIngles = notaGrammar + notaListening + notaReader + notaSpeaking + notaVocabulary + notaReading + notaWriting;
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.Write("Los exámenes  de inglés suman ");
                    Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                    Console.Write(notaFinalIngles);
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    Console.WriteLine(" puntos");
                    Console.ForegroundColor = System.ConsoleColor.DarkBlue;
                    Console.WriteLine("----------------------------------------");
                } else {
                    PedirNotas(true);
                    Console.ForegroundColor = System.ConsoleColor.DarkBlue;
                    Console.WriteLine("----------------------------------------");
                }
                
            }
        }

        static double PedirNotas(bool canBeRed){
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Cantidad de exámenes hechos: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            int cantidadExamenes = Convert.ToInt32(Console.ReadLine());
            double media1 = 0;
            double media2 = 0;

            double[] notas = new double[cantidadExamenes];

            for(int i = 0; i < cantidadExamenes; i++){
                int notaActual = i + 1;
                Console.ForegroundColor = System.ConsoleColor.Green;
                Console.Write("Nota " + notaActual + ": ");
                Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.ForegroundColor = System.ConsoleColor.Green;

            for (int i = 0; i < notas.Length; i++){
                media1 += notas[i];
            }
            media2 = media1 / notas.Length;
            Console.Write("La nota media es de: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.WriteLine(media2);
            Console.ForegroundColor = System.ConsoleColor.Green;

            Console.Write("El porcentaje de los exámenes es de: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            double porcentajeExamenes = Convert.ToDouble(Console.ReadLine());
            double notaFinal = porcentajeExamenes * media2 / 100;
            if(notaFinal < 5 && canBeRed){
                Console.ForegroundColor = System.ConsoleColor.Red;
            } else Console.ForegroundColor = System.ConsoleColor.Green;
            Console.Write("Los exámenes suman: ");
            Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            Console.Write(notaFinal);
            if(notaFinal < 5 && canBeRed){
                Console.ForegroundColor = System.ConsoleColor.Red;
            } else Console.ForegroundColor = System.ConsoleColor.Green;
            
            Console.WriteLine(" puntos.");
            return notaFinal;
        }

        static void Apariencia (){
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------JatoMixo----------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("---------Calculador de exámenes---------");

            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine("----------------------------------------");
            Console.Title = "JatoMixo Console";
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WindowWidth = 40;
        }
    }
}