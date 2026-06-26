#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutpaintImageJSONRequest : global::System.IEquatable<OutpaintImageJSONRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.OutpaintImageRequestBase? Base { get; init; }
#else
        public global::Recraft.OutpaintImageRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.OutpaintImageRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.OutpaintImageRequestBase PickBase() => IsBase
            ? Base!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageJSONRequest? Transform { get; init; }
#else
        public global::Recraft.TransformImageJSONRequest? Transform { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transform))]
#endif
        public bool IsTransform => Transform != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransform(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.TransformImageJSONRequest? value)
        {
            value = Transform;
            return IsTransform;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageJSONRequest PickTransform() => IsTransform
            ? Transform!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transform' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutpaintImageJSONRequest(global::Recraft.OutpaintImageRequestBase value) => new OutpaintImageJSONRequest((global::Recraft.OutpaintImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.OutpaintImageRequestBase?(OutpaintImageJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageJSONRequest(global::Recraft.OutpaintImageRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageJSONRequest FromBase(global::Recraft.OutpaintImageRequestBase? value) => new OutpaintImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutpaintImageJSONRequest(global::Recraft.TransformImageJSONRequest value) => new OutpaintImageJSONRequest((global::Recraft.TransformImageJSONRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageJSONRequest?(OutpaintImageJSONRequest @this) => @this.Transform;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageJSONRequest(global::Recraft.TransformImageJSONRequest? value)
        {
            Transform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageJSONRequest FromTransform(global::Recraft.TransformImageJSONRequest? value) => new OutpaintImageJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageJSONRequest(
            global::Recraft.OutpaintImageRequestBase? @base,
            global::Recraft.TransformImageJSONRequest? transform
            )
        {
            Base = @base;
            Transform = transform;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Transform as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Transform?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTransform;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.OutpaintImageRequestBase?, TResult>? @base = null,
            global::System.Func<global::Recraft.TransformImageJSONRequest?, TResult>? transform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsTransform && transform != null)
            {
                return transform(Transform!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.OutpaintImageRequestBase?>? @base = null,

            global::System.Action<global::Recraft.TransformImageJSONRequest?>? transform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsTransform)
            {
                transform?.Invoke(Transform!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.OutpaintImageRequestBase?>? @base = null,
            global::System.Action<global::Recraft.TransformImageJSONRequest?>? transform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsTransform)
            {
                transform?.Invoke(Transform!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Recraft.OutpaintImageRequestBase),
                Transform,
                typeof(global::Recraft.TransformImageJSONRequest),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OutpaintImageJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.OutpaintImageRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageJSONRequest?>.Default.Equals(Transform, other.Transform) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutpaintImageJSONRequest obj1, OutpaintImageJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutpaintImageJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutpaintImageJSONRequest obj1, OutpaintImageJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutpaintImageJSONRequest o && Equals(o);
        }
    }
}
