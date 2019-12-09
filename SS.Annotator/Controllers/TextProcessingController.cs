using System.Collections.Generic;
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
        [Route("api/TextProcessing/GetTimexs")]
        public JObject GetTimeXs([FromBody]GetTimexsRequest getTimexsRequest)
        {
            var timexs = _namedEntityRecognitionService.GetTimexs(getTimexsRequest.Text);

            var timexsArray = new JArray();
            foreach (var timex in timexs)
            {
                timexsArray.Add(timex);
            }

            dynamic jsonResponse = new JObject();
            jsonResponse.timexsArray = timexsArray;

            return jsonResponse;
        }

        // POST: api/TextProcessing/GetDates
        [HttpPost]
        [Route("api/TextProcessing/GetDates")]
        public JObject GetDates([FromBody]GetDatesRequest getDatesRequest)
        {
            var dates = _namedEntityRecognitionService.GetDates(getDatesRequest.Text);

            var datesArray = new JArray();
            foreach (var date in dates)
            {
                datesArray.Add(date);
            }

            dynamic jsonResponse = new JObject();
            jsonResponse.datesArray = datesArray;

            return jsonResponse;
        }

        // POST: api/TextProcessing/GetPersons
        [HttpPost]
        [Route("api/TextProcessing/GetPersons")]
        public JObject GetPersons([FromBody]GetPersonsRequest getPersonsRequest)
        {
            var persons = _namedEntityRecognitionService.GetPersons(getPersonsRequest.Text);

            var personsArray = new JArray();
            foreach (var person in persons)
            {
                personsArray.Add(person);
            }

            dynamic jsonResponse = new JObject();
            jsonResponse.personsArray = personsArray;

            return jsonResponse;
        }
    }
}
