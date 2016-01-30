using Microsoft.AspNet.Mvc.Razor.Precompilation;
using System;
using Microsoft.Dnx.Compilation.CSharp;

public class EnforceRazorViewCompilation : RazorPreCompileModule
{
    public EnforceRazorViewCompilation() :base()
    {
        this.GenerateSymbols = true;
    }

    protected override bool EnablePreCompilation(BeforeCompileContext context) => true;     
}
