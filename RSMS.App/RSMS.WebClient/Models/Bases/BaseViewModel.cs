using RSMS.Entities.Interfaces;

namespace RSMS.WebClient.Models.Bases;
public abstract class BaseViewModel
{
    public string Title { get; set; }
    public IOperationResponse Response { get; set; }
}