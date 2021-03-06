﻿using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using SS.Annotator.Models;
using Stanford.NLP.NER.CSharp.Interfaces;
using Stanford.NLP.NER.CSharp.Services;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace SS.Annotator.Controllers
{
    public class TextProcessingController : ApiController
    {
        private readonly INamedEntityRecognitionService _namedEntityRecognitionService;

        public TextProcessingController()
        {
            _namedEntityRecognitionService = new NamedEntityRecognitionService();
        }

        // POST: api/TextProcessing/GetPlaces
        [HttpPost]
        [Route("api/TextProcessing/GetPlaces")]
        public JObject GetPlaces([FromBody]GetPlacesRequest getPlacesRequest)
        {
            var places = _namedEntityRecognitionService.GetPlaces(getPlacesRequest.Text);

            var placesArray = new JArray();
            foreach (var place in places)
            {
                placesArray.Add(place);
            }

            dynamic jsonResponse = new JObject();
            jsonResponse.placesArray = placesArray;

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
