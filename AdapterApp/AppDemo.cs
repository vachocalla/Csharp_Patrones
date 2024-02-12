using AdapterApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    class AppDemo : App
    {
        protected override int TrsansactionProcessNumber { get;  } = 1;

        private IEnumerable<string> SkipWords { get; } = new[] {
            "la", 
            "el", 
            "entonces", 
            //"hubo"
        };

        private Func<WordSet> GetWordSetFactory( IEnumerable<string> skipword ) =>
            () => new WordSet( skipword );

        protected override void Implementation()
        {
            var index = new KeywordIndex< IWithSimpleKeywords >();
            var item1 = new Libro("Java Avanzado", "Largo", "interesante");

            var video = new Video("Matrix hubo Largo, Movie Largo", "la-movie-es-excelente-ad");
            var repo = new KeywordsRepository();
            var item2 = new PresetKeywords(
                new VideoKeywords(video, GetWordSetFactory(skipword: SkipWords)),
                repo.FindFor(video.Handle!)
                );

            var otroVideo = new Video("Avatar", "laguna");
            var item3 = new PresetKeywords(
                new VideoKeywords(otroVideo, GetWordSetFactory(skipword: SkipWords)),
                repo.FindFor(otroVideo.Handle!)
                );

            index.Add(item1);
            index.Add(item2);
            index.Add(item3);
            Console.WriteLine(index);
            Console.WriteLine();

            string query = "largo";
            //IEnumerable<IWithSimpleKeywords> resultados = index.Find(query);
            IEnumerable<IWithSimpleKeywords> resultados = index.FindApproximate(query);
            Console.WriteLine( $"Buscando por la palabra {query}: {resultados.ToSequenceString(", ") }" );
        }
    }
}
