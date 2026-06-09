using Microsoft.AspNetCore.Mvc;
using CadastroAlunosApp.Models;
using System;

namespace CadastroAlunosApp.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View(new ImcModel());
        }

        [HttpPost]
        public IActionResult Calcular(ImcModel model)
        {
            // Se o modelo for válido OU se os valores numéricos foram recebidos corretamente
            if (ModelState.IsValid || (model.Peso > 0 && model.Altura > 0))
            {
                // Limpa erros residuais de conversão de ponto/vírgula se houverem
                ModelState.Clear();

                // Cálculo do IMC: Peso / (Altura * Altura)
                model.ResultadoImc = Math.Round(model.Peso / (model.Altura * model.Altura), 2);

                // Definição da classificação
                if (model.ResultadoImc < 18.5)
                    model.Classificacao = "Abaixo do peso";
                else if (model.ResultadoImc < 25)
                    model.Classificacao = "Peso normal";
                else if (model.ResultadoImc < 30)
                    model.Classificacao = "Sobrepeso";
                else
                    model.Classificacao = "Obesidade";

                return View(model);
            }

            // Se falhar completamente, retorna com as mensagens de erro
            return View(model);
        }
    }
}