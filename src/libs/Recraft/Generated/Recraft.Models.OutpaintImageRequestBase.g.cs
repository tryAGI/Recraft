#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutpaintImageRequestBase : global::System.IEquatable<OutpaintImageRequestBase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.TransformImageRequestBase? Transform { get; init; }
#else
        public global::Recraft.TransformImageRequestBase? Transform { get; }
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
            out global::Recraft.TransformImageRequestBase? value)
        {
            value = Transform;
            return IsTransform;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.TransformImageRequestBase PickTransform() => IsTransform
            ? Transform!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transform' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.OutpaintImageRequestBaseVariant2? OutpaintImageRequestBaseVariant2 { get; init; }
#else
        public global::Recraft.OutpaintImageRequestBaseVariant2? OutpaintImageRequestBaseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutpaintImageRequestBaseVariant2))]
#endif
        public bool IsOutpaintImageRequestBaseVariant2 => OutpaintImageRequestBaseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutpaintImageRequestBaseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.OutpaintImageRequestBaseVariant2? value)
        {
            value = OutpaintImageRequestBaseVariant2;
            return IsOutpaintImageRequestBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.OutpaintImageRequestBaseVariant2 PickOutpaintImageRequestBaseVariant2() => IsOutpaintImageRequestBaseVariant2
            ? OutpaintImageRequestBaseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutpaintImageRequestBaseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutpaintImageRequestBase(global::Recraft.TransformImageRequestBase value) => new OutpaintImageRequestBase((global::Recraft.TransformImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.TransformImageRequestBase?(OutpaintImageRequestBase @this) => @this.Transform;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequestBase(global::Recraft.TransformImageRequestBase? value)
        {
            Transform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageRequestBase FromTransform(global::Recraft.TransformImageRequestBase? value) => new OutpaintImageRequestBase(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutpaintImageRequestBase(global::Recraft.OutpaintImageRequestBaseVariant2 value) => new OutpaintImageRequestBase((global::Recraft.OutpaintImageRequestBaseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.OutpaintImageRequestBaseVariant2?(OutpaintImageRequestBase @this) => @this.OutpaintImageRequestBaseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequestBase(global::Recraft.OutpaintImageRequestBaseVariant2? value)
        {
            OutpaintImageRequestBaseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutpaintImageRequestBase FromOutpaintImageRequestBaseVariant2(global::Recraft.OutpaintImageRequestBaseVariant2? value) => new OutpaintImageRequestBase(value);

        /// <summary>
        /// 
        /// </summary>
        public OutpaintImageRequestBase(
            global::Recraft.TransformImageRequestBase? transform,
            global::Recraft.OutpaintImageRequestBaseVariant2? outpaintImageRequestBaseVariant2
            )
        {
            Transform = transform;
            OutpaintImageRequestBaseVariant2 = outpaintImageRequestBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutpaintImageRequestBaseVariant2 as object ??
            Transform as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Transform?.ToString() ??
            OutpaintImageRequestBaseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTransform && IsOutpaintImageRequestBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.TransformImageRequestBase, TResult>? transform = null,
            global::System.Func<global::Recraft.OutpaintImageRequestBaseVariant2, TResult>? outpaintImageRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransform && transform != null)
            {
                return transform(Transform!);
            }
            else if (IsOutpaintImageRequestBaseVariant2 && outpaintImageRequestBaseVariant2 != null)
            {
                return outpaintImageRequestBaseVariant2(OutpaintImageRequestBaseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.TransformImageRequestBase>? transform = null,

            global::System.Action<global::Recraft.OutpaintImageRequestBaseVariant2>? outpaintImageRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransform)
            {
                transform?.Invoke(Transform!);
            }
            else if (IsOutpaintImageRequestBaseVariant2)
            {
                outpaintImageRequestBaseVariant2?.Invoke(OutpaintImageRequestBaseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.TransformImageRequestBase>? transform = null,
            global::System.Action<global::Recraft.OutpaintImageRequestBaseVariant2>? outpaintImageRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTransform)
            {
                transform?.Invoke(Transform!);
            }
            else if (IsOutpaintImageRequestBaseVariant2)
            {
                outpaintImageRequestBaseVariant2?.Invoke(OutpaintImageRequestBaseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Transform,
                typeof(global::Recraft.TransformImageRequestBase),
                OutpaintImageRequestBaseVariant2,
                typeof(global::Recraft.OutpaintImageRequestBaseVariant2),
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
        public bool Equals(OutpaintImageRequestBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.TransformImageRequestBase?>.Default.Equals(Transform, other.Transform) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.OutpaintImageRequestBaseVariant2?>.Default.Equals(OutpaintImageRequestBaseVariant2, other.OutpaintImageRequestBaseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutpaintImageRequestBase obj1, OutpaintImageRequestBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutpaintImageRequestBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutpaintImageRequestBase obj1, OutpaintImageRequestBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutpaintImageRequestBase o && Equals(o);
        }
    }
}
