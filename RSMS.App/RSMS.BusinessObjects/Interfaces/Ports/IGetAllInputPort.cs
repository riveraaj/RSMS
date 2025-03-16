namespace RSMS.BusinessObjects.Interfaces.Ports;
public interface IGetAllInputPort<T>
{
    Task Handle(T param);
}