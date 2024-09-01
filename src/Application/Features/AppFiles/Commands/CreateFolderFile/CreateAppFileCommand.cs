﻿using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Commands.CreateFolderFile
{
    public class CreateAppFileCommand : IRequest<AppFileDto>
    {
        public string? Name { get; set; }
        public string? Discribtion { get; set; }
        public string? Content { get; set; }
        public uint FolderId { get; set; }
       
        public uint FileExtensionId { get; set; }
       
    }
}
