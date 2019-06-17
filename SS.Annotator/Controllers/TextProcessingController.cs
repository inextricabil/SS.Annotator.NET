using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using SS.Annotator.Models;
using Stanford.NLP.NER.CSharp.Interfaces;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace SS.Annotator.Controllers
{
    [Route("api/TextProcessing")]
    public class TextProcessingController : Controller
    {
        private readonly INamedEntityRecognitionService _namedEntityRecognitionService;

        public TextProcessingController(INamedEntityRecognitionService namedEntityRecognitionService)
        {
            _namedEntityRecognitionService = namedEntityRecognitionService;
        }

        // POST: api/TextProcessing/GetPlaces
        [HttpPost]
        public JObject GetPlaces([FromBody]GetPlacesRequest getPlacesRequest)
        {
            var placeIndexes = _namedEntityRecognitionService.GetPlacesIndexes(getPlacesRequest.Text);

            var placeIndexesArray = new JArray();
            foreach (var index in placeIndexes)
            {
                placeIndexesArray.Add(index);
            }

            dynamic jsonResponse = new JObject();
            jsonResponse.placeIndexesArray = placeIndexesArray;

            return jsonResponse;
        }

        // POST: api/TextProcessing/GetTimeXs
        [HttpPost]
        public IEnumerable<string> GetTimeXs([FromBody]string text)
        {
            return new[] { text };
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
