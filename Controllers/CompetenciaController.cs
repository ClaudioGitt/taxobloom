using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.Controllers;
using WebAppBloom.ViewModels;



namespace WebAppBloom.Controllers;
public class CompetenciaController:Controller
{
    
    public IActionResult Index()
    {
        Competencia competencia=new Competencia();
        competencia.ColunaBloom="Memorizar";
        competencia.LinhaBloom="Compreender";
        ViewData["titulo"]="compreender o funcionamento do Razor";
        ViewData["tablebloom"]=competencia;
        return View();
    }
    public IActionResult RelatorioCompe()
    {
    var Competencia=new Competencia()
    {

        ColunaBloom="Teste Coluna",
        LinhaBloom="Teste Linha"
    };
    var viewModel = new DetalhesCompViewModel()
    {
        Competencia=Competencia,
        TituloPagina=" Pagina de teste "
    };
    return View( viewModel);
    }
}


