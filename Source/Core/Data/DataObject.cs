using System;

namespace Core.Data;

/// <summary>
/// Represents a base data object with a unique identifier (Guid).
/// This class is intended to be inherited by other data entities.
/// </summary>
public abstract class DataObject
{
    /// <summary>
    /// Gets the unique identifier (Numeric) of this data object.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Gets the unique identifier (Guid) of this data object.
    /// </summary>
    public string Guid { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataObject"/> class
    /// with a newly generated unique identifier (Guid).
    /// </summary>
    public DataObject()
    {
        this.Guid = System.Guid.NewGuid().ToString();
        this.Id = 0; // TODO -> Add incrment logic.
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataObject"/> class
    /// with a specified unique identifier (Numeric).
    /// </summary>
    /// <param name="id">The unique identifier (Numeric) to assign to this data object.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="guid"/> is null.</exception>
    public DataObject(int id)
    {
        this.Guid = System.Guid.NewGuid().ToString();
        this.Id = id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataObject"/> class
    /// with a specified unique identifier (Guid).
    /// </summary>
    /// <param name="guid">The unique identifier (Guid) to assign to this data object.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="guid"/> is null.</exception>
    public DataObject(string guid)
    {
        this.Guid = guid ?? throw new ArgumentNullException(nameof(guid), "Guid cannot be null.");
        this.Id = 0; // TODO -> Add incrment logic.
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataObject"/> class
    /// with a specified unique identifiers (Guid, Numeric).
    /// </summary>
    /// <param name="id">The unique identifier (Numeric) to assign to this data object.</param>
    /// <param name="guid">The unique identifier (Guid) to assign to this data object.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="guid"/> is null.</exception>
    public DataObject(int id, string guid)
    {
        this.Guid = guid ?? throw new ArgumentNullException(nameof(guid), "Guid cannot be null.");
        this.Id = id;
    }
}
