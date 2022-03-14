using System;
using System.Web.Mvc;

namespace PTC
{
  public static class HtmlExtensionsCommon
  {
    public enum HtmlButtonTypes
    {
      submit,
      button,
      reset
    }

    public static void AddName(TagBuilder tb, string name, string id) {
      if (!string.IsNullOrWhiteSpace(name)) {
        // Ensure we have valid name
        name = TagBuilder.CreateSanitizedId(name);

        if (string.IsNullOrWhiteSpace(id)) {
          // Generate valid 'id' attribute 
          // from the 'name' attribute
          tb.GenerateId(name);
        }
        else {
          // Add 'id' to HTML
          tb.MergeAttribute("id",
              TagBuilder.CreateSanitizedId(id));
        }

        // Add 'name' to HTML
        tb.MergeAttribute("name", name);
      }
    }
  }
}