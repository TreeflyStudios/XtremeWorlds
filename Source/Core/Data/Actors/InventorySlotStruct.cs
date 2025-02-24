namespace Core.Data.Actors;

public struct InventorySlotStruct
{
    public int Num;
    public int Value;
    public byte Bound;

    public InventorySlotStruct()
    {
        this.Num = 0;
        this.Value = 0;
        this.Bound = 0;
    }

    public InventorySlotStruct(int num, int value, byte bound)
    {
        this.Num = num;
        this.Value = value;
        this.Bound = bound;
    }
}
