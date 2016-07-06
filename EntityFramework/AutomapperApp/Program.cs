using AutomapperApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace AutomapperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaSQLimpiaAutomapper();
        }

        static void ConsultaManual()
        {
            Modelo modelo = new Modelo();

            modelo.Database.Log = c => System.Diagnostics.Debug.WriteLine(c);

            var query = from t in modelo.Tracks
                        join m in modelo.MediaTypes on t.MediaTypeId equals m.MediaTypeId
                        join g in modelo.Genres on t.GenreId equals g.GenreId
                        join a in modelo.Albums on t.AlbumId equals a.AlbumId
                        select new TrackCompleteDto
                        {
                            Album = a.Title,
                            Bytes = t.Bytes,
                            Composer = t.Composer,
                            Genre = g.Name,
                            MediaType = m.Name,
                            Milliseconds = t.Milliseconds,
                            Name = t.Name,
                            TrackId = t.TrackId,
                            UnitPrice = t.UnitPrice
                        };

            foreach (var item in query.ToList())
            {
                Console.WriteLine("Album: {0}\nBytes: {1}\nComposer: {2}\nGenre: {3}\nMediaType: {4}\nMilliseconds: {5}\nName: {6}\nTrackId: {7}\nUnitPrice: {8}\n\n",
                    item.Album, item.Bytes, item.Composer, item.Genre, item.MediaType, item.Milliseconds, item.Name, item.TrackId, item.UnitPrice);                
            }
            
            Console.Read();
        }

        static void ConsultaSQLCompletaAutomapper()
        {
            Modelo modelo = new Modelo();

            modelo.Database.Log = c => System.Diagnostics.Debug.WriteLine(c);

            var tracks = (from c in modelo.Tracks select c).ToList();

            Mapper.Initialize(cfg => cfg.CreateMap<Track, SimpleTrack>());

            var query = AutoMapper.Mapper.Map<List<Track>, List<SimpleTrack>>(tracks);            

            foreach (var item in query.ToList())
            {
                Console.WriteLine("TrackId: {0}\nName: {1}\n\n",
                    item.TrackId, item.Name);
            }

            Console.Read();
        }

        static void ConsultaSQLimpiaAutomapper()
        {
            Modelo modelo = new Modelo();

            modelo.Database.Log = c => System.Diagnostics.Debug.WriteLine(c);          

            Mapper.Initialize(cfg => cfg.CreateMap<Track, SimpleTrack>());

            var tracks = (from c in modelo.Tracks select c).Take(5).ProjectTo<SimpleTrack>();

            foreach (var item in tracks.ToList())
            {
                Console.WriteLine("TrackId: {0}\nName: {1}\n\n",
                    item.TrackId, item.Name);
            }

            Console.Read();
        }
    }    
}
