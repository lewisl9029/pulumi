﻿// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

#nullable enable

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3
{
    public class BucketObject : CustomResource
    {
        [Output("acl")]
        public Output<string?> Acl { get; private set; } = null!;

        [Output("bucket")]
        public Output<string> Bucket { get; private set; } = null!;

        [Output("cacheControl")]
        public Output<string?> CacheControl { get; private set; } = null!;

        [Output("content")]
        public Output<string?> Content { get; private set; } = null!;

        [Output("contentBase64")]
        public Output<string?> ContentBase64 { get; private set; } = null!;

        [Output("contentDisposition")]
        public Output<string?> ContentDisposition { get; private set; } = null!;

        [Output("contentEncoding")]
        public Output<string?> ContentEncoding { get; private set; } = null!;

        [Output("contentLanguage")]
        public Output<string?> ContentLanguage { get; private set; } = null!;

        [Output("contentType")]
        public Output<string> ContentType { get; private set; } = null!;

        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        [Output("forceDestroy")]
        public Output<bool?> ForceDestroy { get; private set; } = null!;

        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        [Output("kmsKeyId")]
        public Output<string?> KmsKeyId { get; private set; } = null!;

        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;

        [Output("objectLockLegalHoldStatus")]
        public Output<string?> ObjectLockLegalHoldStatus { get; private set; } = null!;

        [Output("objectLockMode")]
        public Output<string?> ObjectLockMode { get; private set; } = null!;

        [Output("objectLockRetainUntilDate")]
        public Output<string?> ObjectLockRetainUntilDate { get; private set; } = null!;

        [Output("serverSideEncryption")]
        public Output<string> ServerSideEncryption { get; private set; } = null!;

        [Output("source")]
        public Output<AssetOrArchive?> Source { get; private set; } = null!;

        [Output("storageClass")]
        public Output<string> StorageClass { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        [Output("versionId")]
        public Output<string> VersionId { get; private set; } = null!;

        [Output("websiteRedirect")]
        public Output<string?> WebsiteRedirect { get; private set; } = null!;


        public BucketObject(string name, BucketObjectArgs args, CustomResourceOptions? options = null)
            : base("aws:s3/bucketObject:BucketObject", name, args, options)
        {
        }
    }

    public class BucketObjectArgs : ResourceArgs
    {
        [Input("acl")]
        public Input<string>? Acl { get; set; }

        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        [Input("cacheControl")]
        public Input<string>? CacheControl { get; set; }

        [Input("content")]
        public Input<string>? Content { get; set; }

        [Input("contentBase64")]
        public Input<string>? ContentBase64 { get; set; }

        [Input("contentDisposition")]
        public Input<string>? ContentDisposition { get; set; }

        [Input("contentEncoding")]
        public Input<string>? ContentEncoding { get; set; }

        [Input("contentLanguage")]
        public Input<string>? ContentLanguage { get; set; }

        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        [Input("etag")]
        public Input<string>? Etag { get; set; }

        [Input("forceDestroy")]
        public Input<bool>? ForceDestroy { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("kmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;
        public InputMap<string>? Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("objectLockLegalHoldStatus")]
        public Input<string>? ObjectLockLegalHoldStatus { get; set; }

        [Input("objectLockMode")]
        public Input<string>? ObjectLockMode { get; set; }

        [Input("objectLockRetainUntilDate")]
        public Input<string>? ObjectLockRetainUntilDate { get; set; }

        [Input("serverSideEncryption")]
        public Input<string>? ServerSideEncryption { get; set; }

        [Input("source")]
        public Input<AssetOrArchive>? Source { get; set; }

        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;
        public InputMap<object>? Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("websiteRedirect")]
        public Input<string>? WebsiteRedirect { get; set; }

        public BucketObjectArgs()
        {
        }
    }
}