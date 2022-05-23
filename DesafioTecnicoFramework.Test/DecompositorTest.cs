using System.Collections.Generic;
using DesafioTecnicoFramework.Api.Controllers;
using DesafioTecnicoFramework.Api.Domain;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DesafioTecnicoFramework.Test;

public class DecompositorTest
{
    private readonly DecompositorController _controller;

    public DecompositorTest()
    {
        _controller = new DecompositorController();
    }
    
    [Fact]
    public void DecomposeNumber45()
    {
        var decompose = new Decompose();
        decompose.Divisores = new List<int>{ 1, 3, 5, 9, 15, 45};
        decompose.Primos = new List<int>{ 1, 3, 5};
        
        var testeNumber = "45";
        var result = _controller.DecomposeNumber(testeNumber);

        var values = result.Value;
        
        Assert.NotNull(values);
        Assert.Equal(decompose.Divisores.Count, values.Divisores.Count);
        Assert.Equal(decompose.Primos.Count, values.Primos.Count);

        foreach (var divisor in decompose.Divisores)
        {
            Assert.Contains(divisor, values.Divisores);
        }        
        foreach (var primo in decompose.Primos)
        {
            Assert.Contains(primo, values.Primos);
        }
    }
    
    [Fact]
    public void DecomposeNumberIsAString()
    {
        var testeNumber = "Numero";
        var result = _controller.DecomposeNumber(testeNumber);
        
        Assert.Equal(400, (result.Result as ObjectResult)?.StatusCode);
    }
    
    [Fact]
    public void DecomposeNumberIsADouble()
    {
        var testeNumber = "45.2";
        var result = _controller.DecomposeNumber(testeNumber);
        
        Assert.Equal(400, (result.Result as ObjectResult)?.StatusCode);
    }
}