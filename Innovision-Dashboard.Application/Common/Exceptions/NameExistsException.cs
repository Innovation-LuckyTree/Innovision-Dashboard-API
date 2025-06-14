using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovision_Dashboard.Application.Common.Exceptions;

public class NameExistsException : Exception
{
    /// <summary>
    /// Initializes a new instance of the NameExistsException class.
    /// </summary>
    public NameExistsException() : base() { }

    /// <summary>
    /// Initializes a new instance of the NameExistsException class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public NameExistsException(string message) : base(message) { }
}
