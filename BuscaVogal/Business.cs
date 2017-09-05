using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVogal
{
    public class Business
    {
        /// <summary>
        /// Metodo responsavel por buscar o primeiro caracter vogal após a primeira consoante
        /// </summary>
        /// <param name="input">Stream com os dados</param>
        /// <returns>Char encontrado</returns>
        public static char? firstChar(IStream input)
        {
            while (input.hasNext())
            {
                char? atual = input.getNext();

                if (Letras.IsConsoante(atual))
                {
                    if (input.hasNext())
                    {
                        atual = input.getNext();

                        var resultado = BuscarCaracterVogalUnico(ref input, atual);
                        return resultado;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Metodo responsavel por buscar o caracter vogal que não se repete
        /// </summary>
        /// <param name="input">Stream</param>
        /// <param name="atual">Char Atual</param>
        /// <returns>Char encontrado</returns>
        public static char? BuscarCaracterVogalUnico(ref IStream input, char? atual)
        {
            if (atual != null)
            {
                if (input.hasNext())
                {
                    string proximo = input.getNext().ToString().ToLower();

                    if (Letras.IsVogal(atual))
                    {
                        if (!input.repetead(Convert.ToChar(atual)))
                        {
                            if (atual.ToString().ToLower() != proximo)
                            {
                                char? vogal = Convert.ToChar(atual);
                                IStream input2 = input;

                                vogal = BuscarCaracterVogalUnico(ref input, vogal);

                                if (vogal == null)
                                {
                                    if (Letras.IsVogal(Convert.ToChar(proximo)))
                                    {
                                        char? proximoItem = Convert.ToChar(proximo);
                                        vogal = BuscarCaracterVogalUnico(ref input2, proximoItem);
                                    }
                                    else
                                    {
                                        vogal = BuscarCaracterVogalUnico(ref input2, null);
                                    }                                    
                                }

                                return vogal;
                            }
                            else
                            {
                                var lista = input.getRepetead().ToList();
                                lista.Add(atual.Value);

                                input.setRepetead(lista.ToArray());

                                char? vogal = Convert.ToChar(proximo);
                                return vogal = BuscarCaracterVogalUnico(ref input, vogal);
                            }
                        }
                        else
                        {
                            if (Letras.IsVogal(Convert.ToChar(proximo)))
                            {
                                char? proximoItem = Convert.ToChar(proximo);
                                return BuscarCaracterVogalUnico(ref input, proximoItem);
                            }
                            else
                            {
                                return BuscarCaracterVogalUnico(ref input, null);
                            }

                        }
                    }
                    else
                    {
                        if (Letras.IsVogal(Convert.ToChar(proximo)))
                        {
                            char? proximoItem = Convert.ToChar(proximo);
                            return BuscarCaracterVogalUnico(ref input, proximoItem);
                        }
                        else
                        {
                            return BuscarCaracterVogalUnico(ref input, null);
                        }

                    }
                }
                else
                {
                    return atual;
                }
            }
            else
            {
                if (input.hasNext())
                {
                    string proximo = input.getNext().ToString().ToLower();

                    if (!Letras.IsConsoante(Convert.ToChar(proximo)))
                    {
                        char? proximoItem = Convert.ToChar(proximo);
                        return BuscarCaracterVogalUnico(ref input, proximoItem);
                    }
                    else
                    {
                        return BuscarCaracterVogalUnico(ref input, null);
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
