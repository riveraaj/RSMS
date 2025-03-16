namespace RSMS.BusinessObjects.Interfaces.Ports;
public interface ICreateInputPort<TDTO>
{
    Task Handle(TDTO oDTO);
}