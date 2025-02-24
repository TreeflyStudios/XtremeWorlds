namespace Core.Data.Actors.Players;

public struct HotbarSlotStruct
{
    public int Slot;
    public byte SlotType;

    public HotbarSlotStruct()
    {
        this.Slot = 0;
        this.SlotType = 0;
    }

    public HotbarSlotStruct(int slot, byte slotType)
    {
        this.Slot = slot;
        this.SlotType = slotType;
    }
}
