namespace Core.Data.Actors.Skills;

public struct ActorSkillStruct
{
    public int Id;
    public int Cooldown;

    public ActorSkillStruct()
    {
        this.Id = 0;
        this.Cooldown = 0;
    }

    public ActorSkillStruct(int id, int cooldown)
    {
        this.Id = id;
        this.Cooldown = cooldown;
    }

    public int LowerCooldown(int amount)
    {
        if (this.Cooldown - amount > 0)
        {
            this.Cooldown -= amount;
        }
        else
        {
            this.Cooldown = 0;
        }

        return this.Cooldown;
    }

    public int RaiseCooldown(int amount)
    {
        this.Cooldown += amount;

        return this.Cooldown;
    }

    public bool ResetCooldown()
    {
        if (this.Cooldown != 0)
        {
            this.Cooldown = 0;
            return true;
        }

        return false;
    }
}
