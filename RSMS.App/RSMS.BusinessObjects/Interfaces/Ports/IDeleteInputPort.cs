namespace RSMS.BusinessObjects.Interfaces.Ports;
public interface IDeleteInputPort
{
    Task Handle(int id);
}