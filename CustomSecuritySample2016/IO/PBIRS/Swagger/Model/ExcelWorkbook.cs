using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.PBIRS.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ExcelWorkbook : CatalogItem {
    /// <summary>
    /// An array of objects of type Comment that are associated with the ExcelWorkbook CatalogItem.
    /// </summary>
    /// <value>An array of objects of type Comment that are associated with the ExcelWorkbook CatalogItem.</value>
    [DataMember(Name="Comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comments")]
    public List<Comment> Comments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExcelWorkbook {\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
