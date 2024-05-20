using Microsoft.AspNetCore.Components;

namespace XComp.XComponents.XButton;

public partial class XButton
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool Disabled { get; set; }
    
}
