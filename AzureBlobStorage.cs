using Azure.Storage.Blobs;

var client = new BlobContainerClient(connStr, "files");
await client.UploadBlobAsync("a.txt", File.OpenRead("a.txt"));