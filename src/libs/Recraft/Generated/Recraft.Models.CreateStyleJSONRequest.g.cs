#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateStyleJSONRequest : global::System.IEquatable<CreateStyleJSONRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.CreateStyleRequestBase? Base { get; init; }
#else
        public global::Recraft.CreateStyleRequestBase? Base { get; }
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
            out global::Recraft.CreateStyleRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.CreateStyleRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.CreateStyleJSONRequestVariant2? CreateStyleJSONRequestVariant2 { get; init; }
#else
        public global::Recraft.CreateStyleJSONRequestVariant2? CreateStyleJSONRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateStyleJSONRequestVariant2))]
#endif
        public bool IsCreateStyleJSONRequestVariant2 => CreateStyleJSONRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateStyleJSONRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.CreateStyleJSONRequestVariant2? value)
        {
            value = CreateStyleJSONRequestVariant2;
            return IsCreateStyleJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.CreateStyleJSONRequestVariant2 PickCreateStyleJSONRequestVariant2() => IsCreateStyleJSONRequestVariant2
            ? CreateStyleJSONRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateStyleJSONRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStyleJSONRequest(global::Recraft.CreateStyleRequestBase value) => new CreateStyleJSONRequest((global::Recraft.CreateStyleRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.CreateStyleRequestBase?(CreateStyleJSONRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleJSONRequest(global::Recraft.CreateStyleRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateStyleJSONRequest FromBase(global::Recraft.CreateStyleRequestBase? value) => new CreateStyleJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStyleJSONRequest(global::Recraft.CreateStyleJSONRequestVariant2 value) => new CreateStyleJSONRequest((global::Recraft.CreateStyleJSONRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.CreateStyleJSONRequestVariant2?(CreateStyleJSONRequest @this) => @this.CreateStyleJSONRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleJSONRequest(global::Recraft.CreateStyleJSONRequestVariant2? value)
        {
            CreateStyleJSONRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateStyleJSONRequest FromCreateStyleJSONRequestVariant2(global::Recraft.CreateStyleJSONRequestVariant2? value) => new CreateStyleJSONRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleJSONRequest(
            global::Recraft.CreateStyleRequestBase? @base,
            global::Recraft.CreateStyleJSONRequestVariant2? createStyleJSONRequestVariant2
            )
        {
            Base = @base;
            CreateStyleJSONRequestVariant2 = createStyleJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateStyleJSONRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateStyleJSONRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateStyleJSONRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.CreateStyleRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.CreateStyleJSONRequestVariant2, TResult>? createStyleJSONRequestVariant2 = null,
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
            else if (IsCreateStyleJSONRequestVariant2 && createStyleJSONRequestVariant2 != null)
            {
                return createStyleJSONRequestVariant2(CreateStyleJSONRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.CreateStyleRequestBase>? @base = null,

            global::System.Action<global::Recraft.CreateStyleJSONRequestVariant2>? createStyleJSONRequestVariant2 = null,
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
            else if (IsCreateStyleJSONRequestVariant2)
            {
                createStyleJSONRequestVariant2?.Invoke(CreateStyleJSONRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.CreateStyleRequestBase>? @base = null,
            global::System.Action<global::Recraft.CreateStyleJSONRequestVariant2>? createStyleJSONRequestVariant2 = null,
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
            else if (IsCreateStyleJSONRequestVariant2)
            {
                createStyleJSONRequestVariant2?.Invoke(CreateStyleJSONRequestVariant2!);
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
                typeof(global::Recraft.CreateStyleRequestBase),
                CreateStyleJSONRequestVariant2,
                typeof(global::Recraft.CreateStyleJSONRequestVariant2),
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
        public bool Equals(CreateStyleJSONRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.CreateStyleRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.CreateStyleJSONRequestVariant2?>.Default.Equals(CreateStyleJSONRequestVariant2, other.CreateStyleJSONRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateStyleJSONRequest obj1, CreateStyleJSONRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateStyleJSONRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateStyleJSONRequest obj1, CreateStyleJSONRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateStyleJSONRequest o && Equals(o);
        }
    }
}
