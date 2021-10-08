using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Anagrama.Api.Data;
using Anagrama.Api.Model;

namespace Anagrama.Api.Service
{
    public class AnagramaService
    {
        private AppDbContext _context;

        public AnagramaService(AppDbContext context)
        {
            _context = context;
        }

        public List<String> ProcurarPalavra(string palavra)
        {
            var lista = _context.Anagrama.ToList();

            List<String> valida = new List<String>();

            var limite = palavra.Length;
            var palavras = lista.Where(x => x.Palavra.Length == palavra.Length);

            foreach (var a in palavras)
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (a.Palavra.Normalize(NormalizationForm.FormD)
                        .Where(ch => char
                        .GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                        .Contains(palavra[i]) == true)
                    {
                        if (i == palavra.Length - 1)
                        {
                            valida.Add(a.Palavra);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return valida;
        }
    }
}