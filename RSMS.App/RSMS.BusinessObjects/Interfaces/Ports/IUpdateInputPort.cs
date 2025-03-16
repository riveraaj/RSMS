namespace RSMS.BusinessObjects.Interfaces.Ports;
public interface IUpdateInputPort<TDTO>
{
    Task Handle(TDTO oDTO);
}