using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Models;
using BookStore.API.Models.Author;
using BookStore.API.Models.Book;

namespace BookStore.API.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<AuthorCreateDto, Author>().ReverseMap();
        CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
        CreateMap<AuthorUpdateDto, Author>().ReverseMap();


        CreateMap<BookCreateDto, Book>().ReverseMap();
        CreateMap<BookUpdateDto, Book>().ReverseMap();
        CreateMap<Book, BookReadOnlyDto>()
            .ForMember(p => p.AuthorName,
                d => d.MapFrom(map => $"{map.Author.FirstName}{map.Author.LastName}"))
            .ReverseMap();
        
        CreateMap<Book, BookDetailsDto>()
            .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
            .ReverseMap();
    }
}