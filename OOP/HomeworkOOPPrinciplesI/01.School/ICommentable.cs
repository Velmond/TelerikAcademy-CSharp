namespace School
{
    using System;
    using System.Collections.Generic;

    interface ICommentable
    {
        List<string> Comments { get; set; }
    }
}